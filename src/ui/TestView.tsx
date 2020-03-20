import React, {Component} from 'react';
import {Text, View, ViewProps} from 'react-native';

interface TestViewProps extends ViewProps {
    text?: string
}

export class TestView extends Component<TestViewProps> {

    public constructor(props: TestViewProps) {
        super(props);
    }

    render() {
        return (
            <View>
                <Text>
                    8ye7wtf7gfwtyfd
                </Text>
            </View>
        );
    }
}
